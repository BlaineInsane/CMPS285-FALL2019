import React, { useState, Component } from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, ScrollView, ImageBackground, KeyboardAvoidingView } from 'react-native';
import Axios from 'axios';
import AppSettings from "../AppSettings"
import { validationService } from "../index";
import FormInput from '../components/FormInput';

/**   inital state of sign up fields
const SignUpInputs = props => {
    var [signUpInputs] = useState({
        firstName: "",
        lastName: "",
        username: "",
        email: "",
        startYear: 0,
        password: "",
    })
}

//sign up handlers
const firstNameChangeHandler = (event) => {
    signUpInputs.firstName = event.nativeEvent.text;
}
const lastNameChangeHandler = (event) => {
    signUpInputs.lastName = event.nativeEvent.text;
}
const userNameChangeHandler = (event) => {
    signUpInputs.username = event.nativeEvent.text;
}
const emailChangeHandler = (event) => {
    signUpInputs.email = event.nativeEvent.text;
}
const startYearChangeHandler = (event) => {
    signUpInputs.startYear = parseInt(event.nativeEvent.text);
}
const passwordChangeHandler = (event) => {
    signUpInputs.password = event.nativeEvent.text;;
}
/*
const confirmPasswordChangeHandler = (event) => {
    signUpInputs.ConfirmPassword = event.nativeEvent.text;
}
*/





export default class SignUp extends Component {


    constructor(props) {
        super(props);
        this.state = {
            inputs: {
                first_name: {
                    type: "generic",
                    value: ""
                },
                last_name: {
                    type: "generic",
                    value: ""
                },
                username: {
                    type: "username",
                    value: ""
                },
                email: {
                    type: "email",
                    value: ""
                },
                start_year: {
                    type: "year",
                    value: ""
                },
                password: {
                    type: "password",
                    value: ""
                },
                confirm_password: {
                    type: "confirmPassword",
                    value: ""
                },
            }
        };

        this.onInputChange = validationService.onInputChange.bind(this);
        this.getFormValidation = validationService.getFormValidation.bind(this);
        this.setInputPosition = validationService.setInputPosition.bind(this);
        this.submit = this.submit.bind(this);
        this.scrollView = React.createRef();
    }

    submit() {
        const { inputs } = this.state;
        const firstInvalidCoordinate = this.getFormValidation();
        const { navigation } = this.props;
        const createUserAndNavigate = props => {
            createUser();
            navigation.navigate({ routeName: 'CourseCategories' });
        }

        const createUser = () => {
            const url = `${AppSettings.baseUrl}/Users`;
            const { inputs } = this.state;

            Axios.post(url, inputs)

                .then(function (response) {
                    console.log(response)
                    inputs.first_name;
                    inputs.last_name;
                    inputs.username;
                    inputs.email;
                    inputs.start_year;
                    inputs.password;
                })
                .catch(function (error) {
                    console.log(error);
                });
        }

        const checkPasswords = props => {
            const { inputs } = this.state;

            if (inputs.password.value == inputs.confirm_password.value) {
                createUserAndNavigate();
            }

        }

        if (firstInvalidCoordinate !== null) {
            this.scrollView.current.scrollTo({
                x: 0,
                y: firstInvalidCoordinate,
                animated: true,
            });
            return;
        }

        checkPasswords();

    }

    renderError(id) {
        const { inputs } = this.state;
        if (inputs[id].errorLabel) {
            return <Text style={styles.error}>{inputs[id].errorLabel}</Text>;
        }
        return null;
    }


    render() {
        const { inputs } = this.state;

        return (

            <ImageBackground
                style={{
                    flex: 1,
                    position: 'absolute',
                    width: '100%',
                    height: '100%',
                    justifyContent: 'center',
                }}
                source={require('../assets/Background.png')}
            >

                <View style={styles.container}>

                    <View>

                        <Text style={styles.title}>Sign Up</Text>

                    </View>

                    <KeyboardAvoidingView style={styles.inputContainer} behavior="padding">

                        <ScrollView ref={this.scrollView} width={'80%'}>

                            <FormInput
                                label={'First Name'}
                                secure={false}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'first_name', value });
                                }}
                                errorLabel={inputs.first_name.errorLabel}
                                touched={inputs.first_name.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['first_name'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />

                            <FormInput
                                label={'Last Name'}
                                secure={false}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'last_name', value });
                                }}
                                errorLabel={inputs.last_name.errorLabel}
                                touched={inputs.last_name.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['last_name'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />

                            <FormInput
                                label={'Username'}
                                secure={false}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'username', value });
                                }}
                                errorLabel={inputs.username.errorLabel}
                                touched={inputs.username.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['username'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />

                            <FormInput
                                label={'Email'}
                                secure={false}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'email', value });
                                }}
                                errorLabel={inputs.email.errorLabel}
                                touched={inputs.email.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['email'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />

                            <FormInput
                                label={'Start Year'}
                                secure={false}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'start_year', value });
                                }}
                                errorLabel={inputs.start_year.errorLabel}
                                touched={inputs.start_year.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['start_year'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />

                            <FormInput
                                label={'Password'}
                                secure={true}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'password', value });
                                }}
                                errorLabel={inputs.password.errorLabel}
                                touched={inputs.password.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['password'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />

                            <FormInput
                                label={'Confirm Password'}
                                secure={true}
                                onChangeText={value => {
                                    this.onInputChange({ id: 'confirm_password', value });
                                }}
                                errorLabel={inputs.confirm_password.errorLabel}
                                touched={inputs.confirm_password.touched}
                                onLayout={({ nativeEvent }) => {
                                    this.setInputPosition({
                                        ids: ['confirm_password'],
                                        value: nativeEvent.layout.y,
                                    });
                                }}
                            />


                            <View style={styles.button}>
                                <TouchableOpacity><Button title="Sign Up" color='grey' onPress={this.submit} /></TouchableOpacity>
                            </View>

                            {/*
                    <View style={styles.button}><TouchableOpacity><Button title="Log In" color='grey' onPress={() => {
                        props.navigation.navigate({ routeName: 'LogIn' });
                    }} /></TouchableOpacity></View>
                */}

                            <View style={{ height: 145 }} />
                        </ScrollView>
                    </KeyboardAvoidingView>
                </View>

            </ImageBackground >
        );

    };
};


const styles = StyleSheet.create({

    container: {
        height: '100%',
        width: '100%',
        //backgroundColor: '#1E8449',
        justifyContent: 'space-between',

    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'black',
        paddingTop: 100,
        //fontFamily: 'Helvetica',
    },
    inputContainer: {
        flex: 1,
        padding: 8,
        paddingTop: 50,
        paddingBottom: 10,
        justifyContent: 'center',
        alignItems: 'center',
    },
    input: {
        height: 35,
        width: '80%',
        marginBottom: 10,
        borderWidth: 1,
        alignItems: 'center',
        backgroundColor: 'white'
    },
    button: {
        paddingBottom: 15,
        marginTop: 15
    },

});

