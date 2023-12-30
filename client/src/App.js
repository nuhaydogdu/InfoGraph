import "./App.css";
import {Container, Row, Col} from "react-bootstrap";
import Navbar from "./components/Navbar";
import Menu from "./components/Menu";
import Footer from "./components/Footer";
import Content from "./components/Content";

function App() {
  return (
    <Container>
      <Row className="custom-container mb-3">
        <Col>
          <Navbar />
        </Col>
      </Row>
      <Row className="custom-container mb-3">
        <Col sm={3}>
          <Menu />
        </Col>
        <Col>
          <Content />
        </Col>
      </Row>
      <Row className="custom-container mb-3">
        <Col>
          <Footer />
        </Col>
      </Row>
    </Container>
  );
}

export default App;
