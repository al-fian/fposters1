import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
    };

    return (
        <>
            <Slider {...settings}>
                <div>
                    <img src="/images/hero1.png" alt="hero" style={{display: 'block', width: '100%', maxHeight: 500}} />
                </div>
                <div>
                    <img src="/images/hero2.png" alt="hero" style={{display: 'block', width: '100%', maxHeight: 500}} />
                </div>
                <div>
                    <img src="/images/hero3.png" alt="hero" style={{display: 'block', width: '100%', maxHeight: 500}} />
                </div>
                <div>
                    <img src="/images/hero4.png" alt="hero" style={{display: 'block', width: '100%', maxHeight: 500}} />
                </div>
            </Slider>
            <Box display='flex' justifyContent='center' sx={{p: 4}} >
                <Typography variant='h2'>Welcome to Football Posters</Typography>
            </Box>
            <Box display='flex' justifyContent='center' sx={{p: 0}} >
                <Typography variant='h5'>This is a DEMO project</Typography>
            </Box>
            <Box display='flex' justifyContent='center' sx={{p: 0}} >
                <Typography variant='h5'>Please don't use any real card here!</Typography>
            </Box>
            <Box display='flex' justifyContent='center' sx={{p: 0}} >
                <p>For testing, use the card numbers from Stripe <a href="https://stripe.com/docs/testing" target="_blank" rel="noopener noreferrer">here</a> </p>
            </Box>
        </>
    )
}