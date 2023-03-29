import { Component, OnInit } from '@angular/core';
import { StudentService } from '../student.service';
import { ActivatedRoute } from '@angular/router';
import { Student } from 'src/app/models/ui-models/student.model';

@Component({
  selector: 'app-view-student',
  templateUrl: './view-student.component.html',
  styleUrls: ['./view-student.component.css']
})

// implements OnInIt...   
export class ViewStudentComponent implements OnInit {

  studentId: string | null | undefined;

  student: Student = {
    id: '',
    firstName: '',
    lastName: '',
    dateOfBirth: '',
    email: '',
    // Mobile is a number so changes need to be done.
    mobile: 0,
    genderId: '',
    profileImageUrl: '',
    gender: {
      id: '',
      description: ''
    },
    address: {
      id: '',
      physicalAddress: '',
      postalAddress: ''
    }
  };

  constructor(private readonly studentService: StudentService,
    private readonly route: ActivatedRoute,
    // private readonly genderService: GenderService,
    // private snackbar: MatSnackBar,
    /*private router: Router*/) { }

  /**
 * When we click on the student it will hit its ID and then route to purticular student data.
 */
  ngOnInit(): void {
    this.route.paramMap.subscribe(
      (params) => {
        this.studentId = params.get('id');
        if (this.studentId) {
          this.studentService.getStudent(this.studentId)
            .subscribe(
              (successResponse) => {
                // Targeting the student.
                this.student = successResponse;
                console.log(successResponse)
              }
            );
        }
      }
    );
  }
}
