from django.db import models
from django.contrib.auth.models import User 
from django.utils import timezone

class Product(models.Model):
    product_name = models.CharField(max_length=255)
    product_description = models.TextField(max_length=255)
    product = models.ImageField(upload_to='products/')
    posted_date = models.DateTimeField(default=timezone.now)
    sold_date = models.DateTimeField(default=timezone.now)
    user = models.ForeignKey(User, on_delete=models.CASCADE)

class contactus(models.Model):
    email=models.EmailField()
    message=models.CharField(max_length=255)

class UserProfile(models.Model):
    user = models.OneToOneField(User, on_delete=models.CASCADE)
    profile_picture = models.ImageField(upload_to='profile_pictures/', blank=True, null=True)