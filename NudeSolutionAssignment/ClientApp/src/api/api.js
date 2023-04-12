import axios from "axios";

const api = axios.create({
    headers: {
        'Content-Type': "application/json",
    timeout: 1000,
},
});

export default api;