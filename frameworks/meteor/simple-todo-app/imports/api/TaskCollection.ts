import { Mongo } from 'meteor/mongo';

export type TaskType = {
    _id: string,
    text: string,
    isChecked: boolean
    createdAt?: Date
}

export const TasksCollection = new Mongo.Collection<TaskType>('tasks');