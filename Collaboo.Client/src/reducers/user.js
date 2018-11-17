const user = (state = [], action) => {
    switch (action.type) {
      case 'LOGIN':
        return [
          ...state,
          {
            id: action.id
          }
        ]
      default:
        return state
    }
  }
  
  export default user