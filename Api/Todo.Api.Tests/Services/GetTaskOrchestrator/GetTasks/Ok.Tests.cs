namespace Todo.Api.Tests.Services.GetTaskOrchestrator.GetTasks
{
    using System.Collections.Generic;
    using Api.Services;
    using Models;
    using Models.Database;
    using Models.OutputModels;
    using Moq;
    using NUnit.Framework;
    using Task = System.Threading.Tasks.Task;

    public class GetTaskOrchestrator_GetTasks_Ok_Tests
    {
        private IList<Models.Database.Task> databaseTasks = new List<Models.Database.Task>();

        private IList<TaskOutputModel> outputModels = new List<TaskOutputModel>();

        private readonly Mock<ITaskFactory> taskFactory = new Mock<ITaskFactory>();

        private readonly Mock<IDatabaseAccessProvider> databaseAccessProvider = new Mock<IDatabaseAccessProvider>();

        private TasksOrchestrator objectToTest;

        private IList<TaskOutputModel> result;

        [OneTimeSetUp]
        public async Task Setup()
        {
            this.databaseAccessProvider.Setup(m => m.GetTasks()).Returns(System.Threading.Tasks.Task.Run(() => this.databaseTasks));

            this.taskFactory.Setup(m => m.Create(this.databaseTasks)).Returns(this.outputModels);

            this.objectToTest = new TasksOrchestrator(this.taskFactory.Object, this.databaseAccessProvider.Object);

            this.result = await this.objectToTest.GetTasks();
        }

        [Test]
        public void IsTheResult_TheExpected_Object()
        {
            Assert.AreSame(this.outputModels, this.result);
        }
    }
}
