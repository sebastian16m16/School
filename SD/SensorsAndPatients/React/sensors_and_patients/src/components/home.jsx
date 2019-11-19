import React, { Component } from "react";
import { Button, Form } from "react-bootstrap";

class Home extends Component {
  state = {};
  constructor(props) {
    super(props);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleSubmit(event) {
    event.preventDefault();

    fetch("https://localhost:44301/api/start");

    this.props.history.push("/activities");
  }

  render() {
    return (
      <div>
        <div className="d-flex justify-content-center">
          <Form onSubmit={this.handleSubmit}>
            <h3>
              <i>Sensors</i>{" "}
              <b>
                <b>&</b>
              </b>{" "}
              <i>Patients</i>
            </h3>
            <div className="d-flex justify-content-center">
              <Button type="submit" variant="secondary">
                Begin
              </Button>
            </div>
          </Form>
        </div>
      </div>
    );
  }
}

export default Home;
