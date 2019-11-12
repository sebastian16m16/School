import React, { Component } from "react";
import { Modal, Button, Row, Col, Form } from "react-bootstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";

export class AddMedicationPlan extends Component {
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

    fetch("https://localhost:44379/api/medicationplan", {
      method: "POST",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        id: null,
        name: event.target.name.value,
        medication: event.target.medication.value,
        assigned_by: event.target.assigned_by.value
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
              Add Medication Plan
            </Modal.Title>
          </Modal.Header>
          <Modal.Body>
            <Row>
              <Col sm={6}>
                <Form onSubmit={this.handleSubmit}>
                  <Form.Group controlId="name">
                    <Form.Label>Name</Form.Label>
                    <Form.Control
                      type="text"
                      name="Name"
                      required
                      placeholder="Name"
                    />
                  </Form.Group>
                  <Form.Group controlId="medication">
                    <Form.Label>Medication</Form.Label>
                    <Form.Control
                      type="text"
                      name="Medication"
                      required
                      placeholder="Medication ID"
                    />
                  </Form.Group>
                  <Form.Group controlId="assigned_by">
                    <Form.Label>Assigned By Doctor</Form.Label>
                    <Form.Control
                      type="text"
                      name="Assigned By Doctor"
                      required
                      placeholder="Assigned By (Doctor ID)"
                    />
                  </Form.Group>
                  <Form.Group>
                    <Button variant="primary" type="submit">
                      Add
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
export default AddMedicationPlan;
