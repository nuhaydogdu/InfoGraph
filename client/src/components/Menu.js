import React from 'react'
import {Container, Row, Col} from "react-bootstrap";
function Menu() {
  return (
    <Container className='p-3'>
        <Row>
            <Col>
                <ul>
                    <li>Deneme1</li>
                    <li>Deneme2</li>
                    <li>Deneme3</li>
                </ul>
            </Col>
        </Row>
    </Container>
  )
}

export default Menu