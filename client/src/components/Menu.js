import React from 'react'
import { Link } from 'react-router-dom';
import {Container, Row, Col} from "react-bootstrap";
import EqualizerIcon from '@mui/icons-material/Equalizer';
function Menu() {
  // const navigate = useNavigate();
    const menu = ([
      {name:"Anasayfa", path:"/"},
      {name:"Mutluluk" ,path:"/hapinness"},
      {name:"İhracat Endeksi" ,path:"/foregin"},
      {name:"TÜFE" ,path:"/tufe"}
    ])

  return (
    <Container className='custom-container h-100'>
        <Row>
            <Col className='p-3'>
                    <h5 className='menu-baslik'><strong>MENÜ</strong></h5>
                    <hr className='hrStyleTwo'/>
                    {menu.map((item,index) => (
                      <Link to={item.path}>
                         <button className='myButton' key={index}><EqualizerIcon /> {item.name}</button></Link>
                    ))}
            </Col>
        </Row>
    </Container>
  )
}

export default Menu