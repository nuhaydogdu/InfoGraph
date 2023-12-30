import React from 'react'
import '../App.css'
import {Container, Row, Col} from "react-bootstrap";
function Navbar() {
  return (
    <Container className='custom-container mb-3 p-3'>
        <Row>
            <Col>
                Navbar
            </Col>
        </Row>
    </Container>
  )
}

export default Navbar