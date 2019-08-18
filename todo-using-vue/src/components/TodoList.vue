<template>
    <div>
        <div>
            <input type="text" class="todo-input" placeholder="Write a new task here" v-model="newTodo">
        </div>
        <div v-for="todo in todos" :key="todo.id" class="todo-item">
            {{todo.title}}
        </div>
    </div>
</template>

<script>
export default {
  name: 'todo-list',
  data () {
    return {
      newTodo: '',
      todos: [{
          'id': 1,
          'title' : 'I must get myself a cup of tea',
          'completed': false
      }]
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
</style>
