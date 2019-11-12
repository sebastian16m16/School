import React, { Component } from "react";
import { Modal, Button, Row, Col, Form } from "react-bootstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";

export class UpdateCaregiver extends Component {
  constructor(props) {
    super(props);
    this.handleSubmit = this.handleSubmit.bind(this);
    this.state = { snackbaropen: false, snackbarMsg: "" };
  }

  snackbarClose = event => {
    this.setState({ snackbaropen: false });
  };

  handleSubmit(event) {
    event.preventDefault();

    fetch("https://localhost:44379/api/caregiver", {
      method: "PUT",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        id: event.target.id.value,
        first_name: event.target.first_name.value,
        last_name: event.target.last_name.value,
        birthdate: event.target.birthdate.value,
        address: event.target.address.value,
        gender: event.target.gender.value
      })
    })
      .then(res => res.json())
      .then(
        result => {
          this.setState({ snackbaropen: true, snackbarMsg: result });
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
        <Modal
          {...this.props}
          size="lg"
          aria-labelledby="contained-modal-title-vcenter"
          centered
        >
          <Modal.Header closeButton>
            <Modal.Title id="contained-modal-title-vcenter">
              Edit Caregiver
            </Modal.Title>
          </Modal.Header>
          <Modal.Body>
            <Row>
              <Col sm={6}>
                <Form onSubmit={this.handleSubmit}>
                  <Form.Group controlId="id">
                    <Form.Label>Caregiver ID</Form.Label>
                    <Form.Control
                      type="text"
                      name="Doctor ID"
                      required
                      disabled
                      defaultValue={this.props.id}
                      placeholder="Caregiver ID"
                    />
                  </Form.Group>
                  <Form.Group controlId="first_name">
                    <Form.Label>First Name</Form.Label>
                    <Form.Control
                      type="text"
                      name="First Name"
                      required
                      defaultValue={this.props.first_name}
                      placeholder="First Name"
                    />
                  </Form.Group>
                  <Form.Group controlId="last_name">
                    <Form.Label>Last Name</Form.Label>
                    <Form.Control
                      type="text"
                      name="Last Name"
                      required
                      defaultValue={this.props.last_name}
                      placeholder="Last Name"
                    />
                  </Form.Group>
                  <Form.Group controlId="birthdate">
                    <Form.Label>Birthdate</Form.Label>
                    <Form.Control
                      type="text"
                      name="Birthdate"
                      required
                      defaultValue={this.props.birthdate}
                      placeholder="Birthdate"
                    />
                  </Form.Group>
                  <Form.Group controlId="address">
                    <Form.Label>Address</Form.Label>
                    <Form.Control
                      type="text"
                      name="Address"
                      required
                      defaultValue={this.props.address}
                      placeholder="Address"
                    />
                  </Form.Group>
                  <Form.Group controlId="gender">
                    <Form.Label>Gender</Form.Label>
                    <Form.Control
                      type="text"
                      name="Gender"
                      required
                      defaultValue={this.props.gender}
                      placeholder="Gender"
                    />
                  </Form.Group>
                  <Form.Group>
                    <Button variant="primary" type="submit">
                      Edit Caregiver's Info
                    </Button>
                  </Form.Group>
                </Form>
              </Col>
            </Row>
          </Modal.Body>
          <Modal.Footer>
            <Button variant="danger" onClick={this.props.onHide}>
              Close
            </Button>
          </Modal.Footer>
        </Modal>
      </div>
    );
  }
}
export default UpdateCaregiver;
