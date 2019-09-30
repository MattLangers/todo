<template>
    <div>
        <div>
            <input type="text" 
                class="todo-input" 
                placeholder="Write a new task here" 
                v-model="newTodo" 
                @keyup.enter="addTodo">
        </div>
        <div v-for="(todo, index) in todos" :key="todo.id" class="todo-item">
            <div @click="todoIsComplete(index)">
                <input type="checkbox" v-model="todo.isComplete">
            </div>
            <div class="todo-item-left">
                <div v-if="!todo.edit" 
                    @dblclick="editTask(todo)" 
                    class="todo-item-label"
                    v-bind:class="{ complete: todo.isComplete }">{{ todo.title }}</div>
                <input v-else type="text" 
                    v-model="todo.title" 
                    @blur="doneEdit(todo)" 
                    @keyup.enter="doneEdit(todo)" 
                    @keyup.esc="cancelEdit(todo)" 
                    v-focus class="todo-item-edit">
            </div>
            <div class="remove-item" @click="removeTodo(index)">
                <button type="button">Remove</button>
            </div>
        </div>
        <div class="extra-container">
            <div><label></label></div>
        </div>
    </div>
</template>

<script>
export default {
  name: "todo-list",
  idForTodo: 3,
  beforeEditTaskTitleCache: "",
  data () {
    return {
      newTodo: '',
      todos: []
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
            isComplete: false,
            edit: false
        })

        this.newTodo = "";
        this.idForTodo++;
      },
      removeTodo(index){
          this.todos.splice(index, 1);
      },
      todoIsComplete(index) {
          this.todos[index].isComplete = this.todos[index].isComplete ? false : true;
      },
      editTask(todo) {
          if(todo.isComplete === true){
              return;
          }

          this.beforeEditTaskTitleCache = todo.title;
          todo.edit = true;
      },
      doneEdit(todo) {
          if(todo.title.trim().length === 0){
              todo.title = this.beforeEditTaskTitleCache;
          }
          todo.edit = false;
      },
      cancelEdit(todo) {
          todo.title = this.beforeEditTaskTitleCache;
          todo.edit = false;
      }
  },
  directives: {
      focus: {
          inserted: function(element){
              element.focus();
          }
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

    .todo-item {
        margin-bottom: 12px;
        display: flex;
        align-items: center;
        justify-content: space-between;
    }

    .todo-item-left {
        display: flex;
        align-items: center;
    }

    .todo-item-label {
        padding: 10px;
        border: 1px solid white;
        margin-left: 12px;
    }

    .todo-item-edit {
        font-size: 17px;
        color: #2c3e50;
        margin-left: 12px;
        width: 100%;
        padding: 10px;
        border: 1px solid #ccc;
        font-family: 'Avenir', Arial, Helvetica, sans-serif;

        &:focus {
            outline: none;
        }

    }

    .complete {
        text-decoration: line-through;
    }
    .remove-item {
        cursor: pointer;
        margin-left: 14px;
        &:hover {
            color: pink;
        }
    }
</style>