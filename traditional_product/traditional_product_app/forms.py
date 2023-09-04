from django import forms
from django.contrib.auth.forms import UserCreationForm
from django.contrib.auth.models import User
from traditional_product_app import models

from traditional_product_app.models import Product, contactus

class CreateAcountForm(UserCreationForm):
    first_name = forms.CharField(max_length=30, required=True, help_text='Required. Enter your first name.')
    last_name = forms.CharField(max_length=30, required=True, help_text='Required. Enter your last name.')
    profile_picture = forms.ImageField(required=False, help_text='Optional. Upload a profile picture.')

    class Meta:
        model = User
        fields = ['username', 'first_name', 'last_name', 'password1', 'password2', 'profile_picture']



class  Productform(forms.ModelForm):
    class Meta:
        model=  Product
        fields='__all__'    


class contactusform(forms.ModelForm):
    class Meta:
        model= contactus
        fields='__all__'    