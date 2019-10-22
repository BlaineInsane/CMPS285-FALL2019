import { createStackNavigator } from 'react-navigation-stack';
import { createAppContainer } from 'react-navigation';

import WelcomeScreen from '../screens/WelcomeScreen';
import SignUpScreen from '../screens/SignUpScreen';
import LogInScreen from '../screens/LogInScreen';
import CourseCategories from '../screens/CourseCategories';
import CMPSCourses from '../screens/CMPSCourses';
import MathCourses from '../screens/MathCourses';
import NaturalScienceCourses from '../screens/NaturalScienceCourses';
import EnglishCourses from '../screens/EnglishCourses';
import ElectiveCourses from '../screens/ElectiveCourses';
import OtherCourses from '../screens/OtherCourses';
import ProgressScreen from '../screens/ProgressScreen';

const DegreeProgressNavigator = createStackNavigator({
    Welcome: {
        screen: WelcomeScreen,
        navigationOptions: {
            title: 'Welcome',
            header: null
        },
    },
    LogIn: {
        screen: LogInScreen,
        navigationOptions: {
            title: 'Log In',
            header: null
        },
    },
    SignUp: {
        screen: SignUpScreen,
        navigationOptions: {
            title: 'Sign Up',
            header: null
        },
    },
    CourseCategories: {
        screen: CourseCategories,
        navigationOptions: {
            title: 'Course Categories',
            header: null
        },
    },
    CMPSCourses: {
        screen: CMPSCourses,
        navigationOptions: {
            title: 'CMPS Courses',
            header: null
        },
    },
    MathCourses: {
        screen: MathCourses,
        navigationOptions: {
            title: 'Math Courses',
            header: null
        },
    },
    NaturalScienceCourses: {
        screen: NaturalScienceCourses,
        navigationOptions: {
            title: 'Natural Science Courses',
            header: null
        },
    },
    EnglishCourses: {
        screen: EnglishCourses,
        navigationOptions: {
            title: 'English Courses',
            header: null
        },
    },
    ElectiveCourses: {
        screen: ElectiveCourses,
        navigationOptions: {
            title: 'Elective Courses',
            header: null
        },
    },
    OtherCourses: {
        screen: OtherCourses,
        navigationOptions: {
            title: 'Other Courses',
            header: null
        },
    },
    ProgressScreen: {
        screen: ProgressScreen,
        navigationOptions: {
            title: 'Progress Screen',
            header: null
        },
    },
});

export default createAppContainer(DegreeProgressNavigator);