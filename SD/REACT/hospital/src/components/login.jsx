import React, { Component } from "react";
import { Button, Form } from "react-bootstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";

export class Login extends Component {
  constructor(props) {
    super(props);
    this.state = { snackbaropen: false, snackbarMsg: "" };
    this.handleSubmit = this.handleSubmit.bind(this);
    this.snackbarClose = this.snackbarClose.bind(this);
    this.handleLogin = this.handleLogin.bind(this);
  }

  snackbarClose = event => {
    this.setState({ snackbaropen: false });
  };

  handleSubmit(event) {
    event.preventDefault();

    fetch("https://localhost:44379/api/login", {
      method: "Post",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        username: event.target.username.value,
        password: event.target.password.value
      })
    })
      .then(res => res.json())
      .then(
        result => {
          this.setState({
            snackbaropen: true,
            snackbarMsg: this.msgReturn(result)
          });
          this.handleLogin(result);
        },
        error => {
          this.setState({
            snackbaropen: true,
            snackbarMsg: "Operation Failed : " + error
          });
        }
      );
  }

  render() {
    return (
      <div className="container">
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
        <Form onSubmit={this.handleSubmit} className="login-form">
          <h1 className="mt-5 font-weight-bold">Hospital Application</h1>
          <h2 className="mb-2 mt-5">LOGIN</h2>

          <Form.Group controlId="username">
            <Form.Label>Username</Form.Label>
            <Form.Control
              type="text"
              name="username"
              required
              placeholder="Username"
            />
          </Form.Group>
          <Form.Group controlId="password">
            <Form.Label>Password</Form.Label>
            <Form.Control
              type="password"
              name="password"
              required
              placeholder="Password"
            />
          </Form.Group>
          <Button
            variant="secondary"
            className="mt-4 btn-lg btn-block"
            type="submit"
          >
            Login
          </Button>
        </Form>
      </div>
    );
  }

  // additional Methods
  msgReturn = result => {
    switch (result) {
      case "D":
        return "As Doctor";
      case "C":
        return "As Caregiver";
      case "P":
        return "As Patient";
      default:
        return result;
    }
  };

  handleLogin = result => {
    switch (result) {
      case "D":
        this.props.history.push("/doctorUI");
        break;

      case "C":
        this.props.history.push("/Caregiverpage");
        break;

      case "P":
        this.props.history.push("/patientPage");
        break;

      default:
        this.props.history.push("/login");
        break;
    }
  };
}

export default Login;
