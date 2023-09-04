from django.contrib import admin
from traditional_product_app.models import Product, UserProfile, contactus

# Register your models here.
admin.site.register(Product)
admin.site.register(contactus)
admin.site.register(UserProfile)