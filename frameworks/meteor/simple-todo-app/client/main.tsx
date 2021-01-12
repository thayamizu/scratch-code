import React from 'react';
import { Meteor } from 'meteor/meteor';
import { render } from 'react-dom';
import { App } from '/imports/ui/App'
import { createMuiTheme, ThemeProvider } from '@material-ui/core'
Meteor.startup(() => {

  render(
    <ThemeProvider theme={createMuiTheme()}>
      <App />
    </ThemeProvider>, document.getElementById('react-target'));
});
