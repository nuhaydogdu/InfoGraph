import React from 'react'
import {Container, Row, Col} from "react-bootstrap";
import Graphics from './Graphics';

function Content() {
  return (
    <Container className='custom-container p-3 h-100'>
        <Row>
            <Col>Content</Col>
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