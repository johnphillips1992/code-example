app.component('student-create-form', {
    props: {
        allclasses: {
            type: Array,
            required: true
        }
    },
    template:
    /*html*/
  `<form class="student-create-form" @submit.prevent="onSubmit">
    <div class="mb-3">
        <label for="firstName" class="form-label">First Name:</label>
        <input id="firstName" v-model="firstName" class="form-control" maxlength="50">
    </div>
    <div class="mb-3">
        <label for="lastName" class="form-label">Last Name:</label>
        <input id="lastName" v-model="lastName" class="form-control" maxlength="50">
    </div>
    <div class="mb-3">
        <label for="classes" class="form-label">Classes:</label>
        <select id="classes" v-model="classes" multiple="true" class="form-control">
            <option v-for="course in allclasses" :value="course.id">{{ course.name }}</option>
        </select>
    </div>
    <!-- solution -->   
    <input class="btn btn-primary" type="submit" value="Save">  
    </form>`,
    data() {
        return {
            firstName: '',
            lastName: '',
            classes: []
        }
    },
    methods: {
        onSubmit() {
            if (this.firstName === '' || this.lastName === '' || this.classes === []){
                alert('Student is incomplete. Please fill out every field.')
                return
            }
            let student = {
                firstName: this.firstName,
                lastName: this.lastName,
                classIdList: this.classes
            }
            this.$emit('student-submitted', student)

            this.firstName = ''
            this.lastName = ''
            this.classes = []
        }
    }
})