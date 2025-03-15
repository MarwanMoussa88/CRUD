import { Company } from "../Company"

export class CreateEmployee {
    id: string | null = null
    name: string = ""
    age: number = 0
    company: Company = new Company()
    companyId: string = ""
}
