
enum Sizes {
    XS,
    S,
    M,
    L,
    XL
}
enum Categories {
    Women,
    Men,
    Kids,
    HomeDeco
}

export class Product {
    id: number;
    name: string;
    description: string;
    price: number;
    category: Categories;
    size: Sizes;
}
