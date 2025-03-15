import { Company } from "../Company"

export class CreateEmployee {
    id: string = ""
    name: string = ""
    age: string = ""
    company: Company = new Company()
    companyId: string = ""
}
