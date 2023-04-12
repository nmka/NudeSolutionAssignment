import api from "../api";
//  we can pass axios or similar library instance

const insuranceService = {

    createItem: (item) => {
        return  api.post('/item', item)
            .then( (response) => {
            })
            .catch((error) => {
                alert(error);
            });
    },

    getAllItems: () => {
        return api.get('/item')
            .then((response) => {
                return response.data
            })
            .catch((error) => {
                alert(error)
            });
    }
}
export default insuranceService;