import postAPI from "../apiMethods"

export const createItem = (item)  => {
    return postAPI('/item',item);
}