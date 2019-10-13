import { createStackNavigator } from 'react-navigation-stack';
import { createAppContainer } from 'react-navigation';

import WelcomeScreen from '../screens/WelcomeScreen';
import SignUpScreen from '../screens/SignUpScreen';
import LogInScreen from '../screens/LogInScreen';

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
});

export default createAppContainer(DegreeProgressNavigator);