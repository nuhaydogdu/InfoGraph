import React from 'react'
import {Container, Row, Col} from "react-bootstrap";
import Graphics from './Graphics';

function Content() {
  return (
    <Container className='custom-container p-3 h-100'>
        <Row>
            <Col><h3 className='d-flex align-items-center justify-content-center'>Content</h3></Col>
        </Row>
        <Row>
          <Col>
          <Graphics />
          </Col>
        </Row>
    </Container>
  )
}

export default Content