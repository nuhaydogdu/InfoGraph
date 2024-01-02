import {useState} from "react";
import "./App.css";
import {Container, Row, Col} from "react-bootstrap";
import Navbar from "./components/Navbar";
import Menu from "./components/Menu";
import Footer from "./components/Footer";
import Content from "./components/Content";

function App() {
  const [resdata, setResData] = useState([]);
  return (
    <Container className="mt-3">

      {/* navbar */}
      <Row>
        <Col>
          <Navbar />
        </Col>
      </Row>

      {/* content and menu */}
      <Row className="mb-3">
        <Col sm={3}>
          <Menu setResData={setResData}/>
        </Col>
        <Col>
          <Content resdata={resdata}/>
        </Col>
      </Row>

      {/* footer */}
      <Row>
        <Col>
          <Footer />
        </Col>
      </Row>
    </Container>
  );
}

export default App;
