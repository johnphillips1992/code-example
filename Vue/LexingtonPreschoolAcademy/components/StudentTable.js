app.component('student-table',
{
    props: {
        students: {
            type: Array,
            required: true
        }
    },
    template:
    /*html*/
    `
    <div class="student-table">
        <h3>Students:</h3>
        <table class="table table-striped">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students">
                    <td>{{ student.firstName }}</td>
                    <td>{{ student.lastName }}</td>
                </tr>
            </tbody>
        </table>
    </div>
    `
})