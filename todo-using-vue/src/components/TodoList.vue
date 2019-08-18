<template>
    <div>
        <div>
            <input type="text" class="todo-input" placeholder="Write a new task here" v-model="newTodo" @keyup.enter="addTodo">
        </div>
        <div v-for="todo in todos" :key="todo.id" class="todo-item">
            <div>
                {{todo.title}}
            </div>
            <div class="remove-item">
                &times;
            </div>
        </div>
    </div>
</template>

<script>
export default {
  name: 'todo-list',
  idForTodo: 3,
  data () {
    return {
      newTodo: '',
      todos: [{
          'id': 1,
          'title' : 'I must get myself a cup of tea',
          'completed': false
      }]
    }
  },
  methods:{
      addTodo(){

          if(this.newTodo.trim().length === 0){
              return;
          }
          
        this.todos.push({
            id: this.idForTodo,
            title: this.newTodo,
            completed: false
        })

        this.newTodo = "";
        this.idForTodo++;
      }
  }
}
</script>

<style lang="scss">
    .todo-input {
        width: 100%;
        padding: 10px 18px;
        font-size: 18px;
        margin-bottom: 16px;

        &:focus {
            outline: 0;
        }
    }

    .todo-item{
        margin-bottom: 12px;
        display: flex;
        align-items: center;
        justify-content: space-between;
    }
</style>
