const app = Vue.createApp({
    data() {
        return {
            students: [],
            classes: []
        }
    },
    methods: {
        async getStudents() {
            const res = await fetch("http://localhost:5211/api/Student");
            const finalRes = await res.json();
            this.students = finalRes;
        },
        async getClasses() {
            const res = await fetch("http://localhost:5211/api/Class");
            const finalRes = await res.json();
            this.classes = finalRes;
        },
        async createStudent(student) {
            const requestOptions = {
                method: "POST",
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify(student)
            };
            fetch("http://localhost:5211/api/Student/Default/Insert", requestOptions)
                .then(data => 
                    {
                        this.getStudents();
                        this.getClasses();
                    })
        }
    },
    mounted() {
        this.getStudents();
        this.getClasses();
    }
  })
  