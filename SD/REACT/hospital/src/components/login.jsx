import React, { Component } from "react";
import { Button, Form, FormGroup, Label, Input } from "reactstrap";

export class Login extends Component {
  render() {
    return (
      <Form className="login-form">
        <h1 className="mt-5 font-weight-bold">Hospital Application</h1>
        <h2 className="mb-2 mt-5">LOGIN</h2>
        <FormGroup>
          <Label>Username</Label>
          <Input type="Username" placeholder="Username" />
          <Label className="mt-4">Password</Label>
          <Input type="Password" placeholder="Password" />
          <Button variant="primary" className="mt-4 btn-lg btn-block">
            Login
          </Button>
        </FormGroup>
      </Form>
    );
  }
}
