import React from 'react'
import '../App.css'
import {Container, Row, Col, Image} from "react-bootstrap";

function Navbar() {
  return (
    <Container className='custom-container mb-3 p-3'>
        <Row>
            <Col className='ps-5'>
                <Image src='https://cdn.freelogovectors.net/wp-content/uploads/2020/07/manisa-celal-bayar-universitesi_logo.png' style={{ width: '200px', height: '200px' }} rounded/>
            </Col>
            <Col>
            <h1>SOFTWARE PROJECT</h1>
            </Col>
            <Col className='pe-5 ps-0'>
                <Image src='https://cdn.freelogovectors.net/wp-content/uploads/2020/07/manisa-celal-bayar-universitesi_logo.png' style={{ width: '200px', height: '200px' }} rounded/>
            </Col>
        </Row>
    </Container>
  )
}

export default Navbar