import React, { useState } from 'react';
import { TasksCollection } from '/imports/api/TaskCollection'
import { Button, Grid, TextField } from '@material-ui/core'

export const TaskForm = () => {
    const [text, setText] = useState("");
    function handleClick(e: React.MouseEvent) {
        e.preventDefault();

        if (!text)
            return;

        TasksCollection.insert({
            text: text.trim(),
            createdAt: new Date(),
            isChecked: false
        });

        setText("")
    }

    return (
        <Grid container>
            <Grid item xs className="grid__item--padding8">

                <TextField
                    fullWidth
                    placeholder="タスクを入力"
                    onChange={(e) => setText(e.target.value)}
                    value={text}
                />

            </Grid>
            <Grid item xs className="grid__item--padding8" >
                <Button color="primary" variant="outlined" onClick={handleClick}>{"追加"}</Button>
            </Grid>
        </Grid>

    );
};