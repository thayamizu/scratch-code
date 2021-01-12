import React from 'react'
import { useTracker } from 'meteor/react-meteor-data'
import { TasksCollection, TaskType } from '/imports/api/TaskCollection'
import { Task } from './Task'
import { TaskForm } from './TaskForm'
import { Grid, AppBar, IconButton, Toolbar, Typography, Button } from "@material-ui/core"
import MenuIcon from '@material-ui/icons/Menu';

const toggleChecked = ({ _id, isChecked }: TaskType) => {
  TasksCollection.update(_id, {
    $set: {
      isChecked: !isChecked
    }
  })
};

const deleteTask = ({ _id }: TaskType) => TasksCollection.remove(_id);

export const App = () => {
  const tasks = useTracker(() => TasksCollection.find({}).fetch());
  return (<div>
    <AppBar position="static">
      <Toolbar>
        <IconButton edge="start" className="nav__icon" color="inherit" aria-label="menu">
          <MenuIcon />
        </IconButton>
        <Typography variant="h6" className="nav__text">
          Simple Todo
        </Typography>
      </Toolbar>
    </AppBar>

    <Grid container className="grid__item--padding16">
      <TaskForm />
    </Grid>

    <Grid container className="grid__item--padding16">

      {
        tasks.map(e => {
          return (
            <Task key={e._id} task={e} onCheckboxClick={toggleChecked} onRemoveClick={deleteTask} />
          )
        })
      }

    </Grid>

  </div>)
}
