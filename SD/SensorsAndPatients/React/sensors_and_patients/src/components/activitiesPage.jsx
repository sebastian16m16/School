import React, { Component } from "react";
import { Table, Button, Form } from "react-bootstrap";

class ActivitiesPage extends Component {
  constructor(props) {
    super(props);
    this.state = { Activities: [] };
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  componentDidMount() {
    this.refreshList();
  }

  componentDidUpdate() {
    this.refreshList();
  }

  handleSubmit() {
    fetch("https://localhost:44301/api/activity", {
      method: "DELETE",
      headers: { "content-type": "application/json" }
    });
  }

  refreshList() {
    fetch("https://localhost:44301/api/activity")
      .then(res => res.json())
      .then(data => {
        this.setState({ Activities: data });
      });
  }

  render() {
    const { Activities } = this.state;
    return (
      <div>
        <Table className="DottedBox" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>Activity ID</th>
              <th>Start Time</th>
              <th>End Time</th>
              <th>Activity</th>
              <th>Patient</th>
            </tr>
          </thead>
          <tbody>
            {Activities.map(activity => (
              <tr key={activity.id}>
                <td>{activity.id}</td>
                <td>{activity.start_time}</td>
                <td>{activity.end_time}</td>
                <td>{activity.activity_label}</td>
                <td>{activity.patient}</td>
                <td></td>
              </tr>
            ))}
          </tbody>
        </Table>
        <div className="d-flex justify-content-center">
          <Form onSubmit={this.handleSubmit}>
            <Button>Reset</Button>
          </Form>
        </div>
      </div>
    );
  }
}

export default ActivitiesPage;
