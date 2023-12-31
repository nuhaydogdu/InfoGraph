import {useState} from 'react'
import {Container, Row, Col} from "react-bootstrap";
import EqualizerIcon from '@mui/icons-material/Equalizer';
function Menu() {
    const [menu, setMenu] = useState([
        "Deneme1",
        "Deneme2",
        "Deneme3"
    ])
  return (
    <Container className='custom-container h-100'>
        <Row>
            <Col className='p-3'>
                    <h5 className='menu-baslik'><strong>MENÜ</strong></h5>
                    <hr className='hrStyleTwo'/>
                    {menu.map((item) => (
                         <button className='myButton'><EqualizerIcon /> {item}</button>
                    ))}
            </Col>
        </Row>
    </Container>
  )
}

export default Menu