import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, ImageBackground } from 'react-native';
import CourseItemComponent from '../components/CourseItemComponent';

const MathCourses = props => {

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
                    <Text style={styles.title}>Math Courses</Text>
                </View>

                <View style={styles.itemContainer}>

                    <View style={styles.item}><CourseItemComponent title={'Math 200'} /></View>

                    <View style={styles.item}><CourseItemComponent title={'Math 201'} /></View>

                    <View style={styles.item}><CourseItemComponent title={'Math 380'} /></View>

                    <View style={styles.item}><CourseItemComponent title={'Math Elective'} /></View>

                    <View style={styles.item}><CourseItemComponent title={'Math Elective'} /></View>

                </View>

                <View style={styles.buttonContainer}>
                    <View style={styles.item}>
                        <TouchableOpacity>
                            <Button title="Select and Return to Course Categories" color='black' onPress={() => {
                                props.navigation.navigate({ routeName: 'CourseCategories' });
                            }} />
                        </TouchableOpacity>
                    </View>
                </View>




            </View>

        </ImageBackground>

    );
};

const styles = StyleSheet.create({

    container: {
        flex: 1,
        //backgroundColor: '#1E8449',
        alignItems: 'center',
        width: '100%',
    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'white',
        paddingTop: 60,
        //fontFamily: 'Helvetica',
    },
    itemContainer: {
        paddingTop: 95,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%',
    },
    buttonContainer: {
        paddingTop: 30,
        alignItems: 'center',
        justifyContent: 'center',
        width: '100%',
    },
    item: {
        width: '80%',
        paddingBottom: 20,
    }

});

export default MathCourses;