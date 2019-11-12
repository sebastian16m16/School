import React, { Component } from "react";
import { Modal, Button, Row, Col, Form } from "react-bootstrap";
import SnackBar from "@material-ui/core/Snackbar";
import IconButton from "@material-ui/core/IconButton";

export class UpdateMedication extends Component {
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

    fetch("https://localhost:44379/api/medication", {
      method: "PUT",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        id: event.target.id.value,
        name: event.target.name.value,
        side_effect: event.target.side_effect.value,
        dosage: event.target.dosage.value
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
              Edit Medication
            </Modal.Title>
          </Modal.Header>
          <Modal.Body>
            <Row>
              <Col sm={6}>
                <Form onSubmit={this.handleSubmit}>
                  <Form.Group controlId="id">
                    <Form.Label>Medication ID</Form.Label>
                    <Form.Control
                      type="text"
                      name="Medication ID"
                      required
                      disabled
                      defaultValue={this.props.id}
                      placeholder="Medication ID"
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
                  <Form.Group controlId="side_effect">
                    <Form.Label>Side Effect</Form.Label>
                    <Form.Control
                      type="text"
                      name="Side Effect"
                      required
                      defaultValue={this.props.side_effect}
                      placeholder="Side Effect"
                    />
                  </Form.Group>
                  <Form.Group controlId="dosage">
                    <Form.Label>Dosage</Form.Label>
                    <Form.Control
                      type="text"
                      name="Dosage"
                      required
                      defaultValue={this.props.dosage}
                      placeholder="Dosage)"
                    />
                  </Form.Group>
                  <Form.Group>
                    <Button variant="primary" type="submit">
                      Edit Medication Info
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
export default UpdateMedication;
