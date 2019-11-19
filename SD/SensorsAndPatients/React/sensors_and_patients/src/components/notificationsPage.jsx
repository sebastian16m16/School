import React, { Component } from "react";
import { Table } from "react-bootstrap";

class NotificationPage extends Component {
  constructor(props) {
    super(props);
    this.state = { Notifications: [] };
  }

  componentDidMount() {
    this.refreshList();
  }

  componentDidUpdate() {
    this.refreshList();
  }

  refreshList() {
    fetch("https://localhost:44301/api/notification")
      .then(res => res.json())
      .then(data => {
        this.setState({ Notifications: data });
      });
  }

  render() {
    const { Notifications } = this.state;
    return (
      <div>
        <Table className="DottedBox" striped bordered hover size="sm">
          <thead>
            <tr>
              <th>Notification ID</th>
              <th>Notified</th>
              <th>About</th>
            </tr>
          </thead>
          <tbody>
            {Notifications.map(notification => (
              <tr key={notification.id}>
                <td>{notification.id}</td>
                <td>{notification.notify}</td>
                <td>{notification.about}</td>
                <td></td>
              </tr>
            ))}
          </tbody>
        </Table>
      </div>
    );
  }
}

export default NotificationPage;
