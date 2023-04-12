import api from "../api";
//  we can pass axios or similar library instance

const insuranceService = {

    createItem: (item) => {
        return api.post('/items', item)
            .then( (response) => {
            })
            .catch((error) => {
                alert(error);
            });
    },

    getAllItems: () => {
        return api.get('/items')
            .then((response) => {
                return response.data
            })
            .catch((error) => {
                alert(error)
            });
    },

    getAllCategories: () => {
        return api.get('/itemcategories')
            .then((response) => {
                return response.data
            })
            .catch((error) => {
                alert(error)
            });
    }
}
export default insuranceService;