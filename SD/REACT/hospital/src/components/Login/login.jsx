import React, { Component } from "react";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";
// import DoctorPage from "./components/Doctor/doctorPage";
// import CaregiverPage from "./components/Caregiver/caregiverPage";
// import Navigation from "./components/layout/navigation";
import { BrowserRouter, Route, Redirect, Switch } from "react-router-dom";


export class Login extends Component {

  constructor(props){
    super(props);
    this.handleSubmit = this.handleSubmit.bind(this);
    this.goTo = this.goTo.bind(this);
  }

  goTo = (x) =>{
    switch(x){
      // case 'D': this.props.history.push('/doctorpage')
      //   break;
      // case 'C': this.props.history.push('/caregiverpage')
      //   break;
    }
  }

  handleSubmit(event) {
    event.preventDefault();

    fetch("https://localhost:44379/api/login", {
      method: "Get",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        username: event.target.username.value,
        password: event.target.last_name.value,
      })
    })
    .then(res => res.json())
      .then(
        result => {
          this.setState({ snackbaropen: true, snackbarMsg: result });
          this.goTo(result);
        },
        error => {
          this.setState({
            snackbaropen: true,
            snackbarMsg: "Operation Failed"
          });
        }
      );
  }
    render() {
      return (
        <Form className="login-form" onSubmit={this.handleSubmit}>
          <SnackBar
          anchorOrigin={{ vertical: "bottom", horizontal: "center" }}
          open={this.state.snackbaropen}
          autoHideDuration={3000}
          onClose={this.snackbarClose}
          message={<span id="message-id">{this.state.snackbarMsg}</span>}
          action={[
            <IconButton
              key="close"
              arial-label="Close"
              color="inherit"
              onClick={this.snackbarClose}
            >
              x
            </IconButton>
          ]}
        ></SnackBar>
          <h1 className="mt-5 font-weight-bold">Hospital Application</h1>
          <h2 className="mb-2 mt-5">LOGIN</h2>
          <FormGroup >
            <Label>Username</Label>
            <Input type="username" placeholder="Username" />
            <Label className="mt-4">Password</Label>
            <Input type="password" placeholder="Password" />
            <Button variant="primary" className="mt-4 btn-lg btn-block" type="submit">
              Login
            </Button>
          </FormGroup>
        </Form>
      );
    }
}

