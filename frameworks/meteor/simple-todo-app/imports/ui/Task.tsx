import React from 'react';
import { TaskType } from '/imports/api/TaskCollection'
import { Button, Checkbox, FormControlLabel, Grid } from '@material-ui/core'

export type TaskProps = {
  task: TaskType
  onCheckboxClick: (e: TaskType) => void
  onRemoveClick: (e: TaskType) => void
}

export const Task = ({ task, onCheckboxClick, onRemoveClick }: TaskProps) => {
  return (
    <Grid container>
      <Grid item xs className="grid__item--padding8">
        <FormControlLabel
          control={<Checkbox

            color="primary"
            checked={task.isChecked}
            onClick={() => onCheckboxClick(task)}

          ></Checkbox>}

          label={task.text} />
      </Grid>
      <Grid
        item xs >
        <Button color="secondary" variant="contained" className="grid__item--padding8" onClick={() => { onRemoveClick(task) }}>{"削除"}</Button>
      </Grid>
    </Grid>
  )
};