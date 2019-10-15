import React from 'react';
import { StyleSheet, Text, View, Button, TouchableOpacity, TextInput } from 'react-native';
import CourseItem from '../components/CourseItem';

const CourseCategories = props => {

    return (

        <View style={styles.container}>

            <View>
                <Text style={styles.title}>Course Categories</Text>
            </View>

            <View style={styles.itemContainer}>

                <View style={styles.item}><CourseItem title={'Computer Science'} nav={() => { 
                    props.navigation.navigate({ routeName: 'CMPSCourses' });
                }} /></View>

                <View style={styles.item}><CourseItem title={'Math'} nav={() => { 
                    props.navigation.navigate({ routeName: 'MathCourses' });
                }} /></View>

                <View style={styles.item}><CourseItem title={'Natural Science'} nav={() => { 
                    props.navigation.navigate({ routeName: 'NaturalScienceCourses' });
                }} /></View>

                <View style={styles.item}><CourseItem title={'English'} nav={() => { 
                    props.navigation.navigate({ routeName: 'EnglishCourses' });
                }} /></View>

                <View style={styles.item}><CourseItem title={'Electives'} nav={() => { 
                    props.navigation.navigate({ routeName: 'ElectiveCourses' });
                }} /></View>

                <View style={styles.item}><CourseItem title={'Other'} nav={() => { 
                    props.navigation.navigate({ routeName: 'OtherCourses' });
                }} /></View>

            </View>

            <View style={styles.buttonContainer}>
                <View style={styles.item}>
                    <TouchableOpacity>
                        <Button title="View Progress" color='black' />
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

export default CourseCategories;