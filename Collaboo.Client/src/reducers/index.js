import { applyMiddleware, combineReducers } from 'redux'
import logger from 'redux-logger'
import user from './user'

export default combineReducers({
  user,
  applyMiddleware(logger)
});