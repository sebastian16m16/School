import React, { Component } from "react";
import { Modal, Button, Row, Col, Form } from "react-bootstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";

export class UpdateMedicationPlan extends Component {
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
      method: "PUT",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        id: event.target.id.value,
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
              Edit Medication Plan
            </Modal.Title>
          </Modal.Header>
          <Modal.Body>
            <Row>
              <Col sm={6}>
                <Form onSubmit={this.handleSubmit}>
                  <Form.Group controlId="id">
                    <Form.Label>Medication Plan ID</Form.Label>
                    <Form.Control
                      type="text"
                      name="Medication Plan ID"
                      required
                      disabled
                      defaultValue={this.props.id}
                      placeholder="Medication Plan ID"
                    />
                  </Form.Group>
                  <Form.Group controlId="name">
                    <Form.Label>Name</Form.Label>
                    <Form.Control
                      type="text"
                      name="Name"
                      required
                      defaultValue={this.props.name}
                      placeholder="Name"
                    />
                  </Form.Group>
                  <Form.Group controlId="medication">
                    <Form.Label>Medication</Form.Label>
                    <Form.Control
                      type="text"
                      name="Medication"
                      required
                      defaultValue={this.props.medication}
                      placeholder="Medication ID"
                    />
                  </Form.Group>
                  <Form.Group controlId="assigned_by">
                    <Form.Label>Assigned By</Form.Label>
                    <Form.Control
                      type="text"
                      name="Assigned By"
                      required
                      defaultValue={this.props.assigned_by}
                      placeholder="Assigned By (Doctor ID)"
                    />
                  </Form.Group>
                  <Form.Group>
                    <Button variant="primary" type="submit">
                      Edit Medication Plan Info
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
export default UpdateMedicationPlan;
