import React from 'react'
import '../App.css'
import {Container, Row, Col, Image} from "react-bootstrap";
import logo from '../images/logo.png'
function Navbar() {
  return (
    <Container className='custom-container mb-3 p-3'>
        <Row>
            <Col className='ps-5'>
                <Image src='https://cdn.freelogovectors.net/wp-content/uploads/2020/07/manisa-celal-bayar-universitesi_logo.png' style={{ width: '200px', height: '200px' }} rounded/>
            </Col>
            <Col className='d-flex align-items-center justify-content-center'>
            
           <h1>Software Project</h1>
            
            </Col>
            <Col className='pe-5 d-flex align-items-end justify-content-end'>
                <Image src= {logo} style={{ width: '200px', height: '200px' }} rounded/>
            </Col>
        </Row>
    </Container>
  )
}

export default Navbar