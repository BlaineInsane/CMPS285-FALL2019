import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput } from 'react-native';
import CourseItem from '../components/CourseItem';

const OtherCourses = props => {

    return (

        <View style={styles.container}>

            <View>
                <Text style={styles.title}>Other Courses</Text>
            </View>

            <View style={styles.itemContainer}>

                <View style={styles.item}><CourseItem title={'art, dnce, mus, or thea'} /></View>

                <View style={styles.item}><CourseItem title={'History Elective'} /></View>

                <View style={styles.item}><CourseItem title={'COMM 211'} /></View>

                <View style={styles.item}><CourseItem title={'econ 201 or econ 202'} /></View>

                <View style={styles.item}><CourseItem title={'social science'} /></View>

                <View style={styles.item}><CourseItem title={'se 101 or free elective'} /></View>

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


    );
};

const styles = StyleSheet.create({

    container: {
        flex: 1,
        backgroundColor: '#1E8449',
        alignItems: 'center',
        width: '100%',
    },
    title: {
        fontSize: 35,
        textAlign: "center",
        color: 'black',
        paddingTop: 60,
        //fontFamily: 'Helvetica',
    },
    itemContainer: {
        paddingTop: 60,
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

export default OtherCourses;