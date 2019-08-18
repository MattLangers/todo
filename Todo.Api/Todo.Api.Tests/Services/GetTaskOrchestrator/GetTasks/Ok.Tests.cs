namespace Todo.Api.Tests.Services.GetTaskOrchestrator.GetTasks
{
    using System.Collections.Generic;
    using Api.Services;
    using Models;
    using Models.OutputModels;
    using Moq;
    using NUnit.Framework;

    public class GetTaskOrchestrator_GetTasks_Ok_Tests
    {
        private IEnumerable<Models.Database.Task> databaseTasks = new List<Models.Database.Task>();

        private IEnumerable<Task> outputModels = new List<Task>();

        private readonly Mock<ITaskFactory> taskFactory = new Mock<ITaskFactory>();

        private readonly Mock<IDatabaseAccessProvider> databaseAccessProvider = new Mock<IDatabaseAccessProvider>();

        private GetTaskOrchestrator objectToTest;

        private IEnumerable<Task> result;

        [OneTimeSetUp]
        public void Setup()
        {
            this.databaseAccessProvider.Setup(m => m.GetTasks()).Returns(this.databaseTasks);

            this.taskFactory.Setup(m => m.Create(this.databaseTasks)).Returns(this.outputModels);

            this.objectToTest = new GetTaskOrchestrator(this.taskFactory.Object, this.databaseAccessProvider.Object);

            this.result = this.objectToTest.GetTasks();
        }

        [Test]
        public void IsTheResult_TheExpected_Object()
        {
            Assert.AreSame(this.outputModels, this.result);
        }
    }
}
