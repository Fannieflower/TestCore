using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class GoodsInfoHelper : TBeanSerializer<GoodsInfo>
	{
		
		public static GoodsInfoHelper OBJ = new GoodsInfoHelper();
		
		public static GoodsInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GoodsInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsId(value);
					}
					
					
					
					
					
					if ("goodsName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsName(value);
					}
					
					
					
					
					
					if ("goodsDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsDesc(value);
					}
					
					
					
					
					
					if ("destUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestUrl(value);
					}
					
					
					
					
					
					if ("goodsThumbUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsThumbUrl(value);
					}
					
					
					
					
					
					if ("goodsCarouselPictures".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoodsCarouselPictures(value);
					}
					
					
					
					
					
					if ("goodsMainPicture".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsMainPicture(value);
					}
					
					
					
					
					
					if ("categoryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCategoryId(value);
					}
					
					
					
					
					
					if ("categoryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategoryName(value);
					}
					
					
					
					
					
					if ("sourceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSourceType(value);
					}
					
					
					
					
					
					if ("marketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMarketPrice(value);
					}
					
					
					
					
					
					if ("vipPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipPrice(value);
					}
					
					
					
					
					
					if ("commissionRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommissionRate(value);
					}
					
					
					
					
					
					if ("commission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommission(value);
					}
					
					
					
					
					
					if ("discount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscount(value);
					}
					
					
					
					
					
					if ("goodsDetailPictures".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoodsDetailPictures(value);
					}
					
					
					
					
					
					if ("cat1stId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCat1stId(value);
					}
					
					
					
					
					
					if ("cat1stName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCat1stName(value);
					}
					
					
					
					
					
					if ("cat2ndId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCat2ndId(value);
					}
					
					
					
					
					
					if ("cat2ndName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCat2ndName(value);
					}
					
					
					
					
					
					if ("brandStoreSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandStoreSn(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("brandLogoFull".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandLogoFull(value);
					}
					
					
					
					
					
					if ("schemeEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSchemeEndTime(value);
					}
					
					
					
					
					
					if ("sellTimeFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSellTimeFrom(value);
					}
					
					
					
					
					
					if ("sellTimeTo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSellTimeTo(value);
					}
					
					
					
					
					
					if ("weight".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetWeight(value);
					}
					
					
					
					
					
					if ("storeInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.adp.api.open.service.StoreInfo value;
						
						value = new com.vip.adp.api.open.service.StoreInfo();
						com.vip.adp.api.open.service.StoreInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetStoreInfo(value);
					}
					
					
					
					
					
					if ("commentsInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.adp.api.open.service.GoodsCommentsInfo value;
						
						value = new com.vip.adp.api.open.service.GoodsCommentsInfo();
						com.vip.adp.api.open.service.GoodsCommentsInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetCommentsInfo(value);
					}
					
					
					
					
					
					if ("storeServiceCapability".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.adp.api.open.service.StoreServiceCapability value;
						
						value = new com.vip.adp.api.open.service.StoreServiceCapability();
						com.vip.adp.api.open.service.StoreServiceCapabilityHelper.getInstance().Read(value, iprot);
						
						structs.SetStoreServiceCapability(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("schemeStartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSchemeStartTime(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(GoodsInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsName() != null) {
				
				oprot.WriteFieldBegin("goodsName");
				oprot.WriteString(structs.GetGoodsName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsDesc() != null) {
				
				oprot.WriteFieldBegin("goodsDesc");
				oprot.WriteString(structs.GetGoodsDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestUrl() != null) {
				
				oprot.WriteFieldBegin("destUrl");
				oprot.WriteString(structs.GetDestUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsThumbUrl() != null) {
				
				oprot.WriteFieldBegin("goodsThumbUrl");
				oprot.WriteString(structs.GetGoodsThumbUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsCarouselPictures() != null) {
				
				oprot.WriteFieldBegin("goodsCarouselPictures");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetGoodsCarouselPictures()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsMainPicture() != null) {
				
				oprot.WriteFieldBegin("goodsMainPicture");
				oprot.WriteString(structs.GetGoodsMainPicture());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryId() != null) {
				
				oprot.WriteFieldBegin("categoryId");
				oprot.WriteI64((long)structs.GetCategoryId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryName() != null) {
				
				oprot.WriteFieldBegin("categoryName");
				oprot.WriteString(structs.GetCategoryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSourceType() != null) {
				
				oprot.WriteFieldBegin("sourceType");
				oprot.WriteI32((int)structs.GetSourceType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarketPrice() != null) {
				
				oprot.WriteFieldBegin("marketPrice");
				oprot.WriteString(structs.GetMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipPrice() != null) {
				
				oprot.WriteFieldBegin("vipPrice");
				oprot.WriteString(structs.GetVipPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionRate() != null) {
				
				oprot.WriteFieldBegin("commissionRate");
				oprot.WriteString(structs.GetCommissionRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommission() != null) {
				
				oprot.WriteFieldBegin("commission");
				oprot.WriteString(structs.GetCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscount() != null) {
				
				oprot.WriteFieldBegin("discount");
				oprot.WriteString(structs.GetDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsDetailPictures() != null) {
				
				oprot.WriteFieldBegin("goodsDetailPictures");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetGoodsDetailPictures()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCat1stId() != null) {
				
				oprot.WriteFieldBegin("cat1stId");
				oprot.WriteI64((long)structs.GetCat1stId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCat1stName() != null) {
				
				oprot.WriteFieldBegin("cat1stName");
				oprot.WriteString(structs.GetCat1stName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCat2ndId() != null) {
				
				oprot.WriteFieldBegin("cat2ndId");
				oprot.WriteI64((long)structs.GetCat2ndId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCat2ndName() != null) {
				
				oprot.WriteFieldBegin("cat2ndName");
				oprot.WriteString(structs.GetCat2ndName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandStoreSn() != null) {
				
				oprot.WriteFieldBegin("brandStoreSn");
				oprot.WriteString(structs.GetBrandStoreSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandLogoFull() != null) {
				
				oprot.WriteFieldBegin("brandLogoFull");
				oprot.WriteString(structs.GetBrandLogoFull());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSchemeEndTime() != null) {
				
				oprot.WriteFieldBegin("schemeEndTime");
				oprot.WriteI64((long)structs.GetSchemeEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeFrom() != null) {
				
				oprot.WriteFieldBegin("sellTimeFrom");
				oprot.WriteI64((long)structs.GetSellTimeFrom()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeTo() != null) {
				
				oprot.WriteFieldBegin("sellTimeTo");
				oprot.WriteI64((long)structs.GetSellTimeTo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWeight() != null) {
				
				oprot.WriteFieldBegin("weight");
				oprot.WriteI32((int)structs.GetWeight()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreInfo() != null) {
				
				oprot.WriteFieldBegin("storeInfo");
				
				com.vip.adp.api.open.service.StoreInfoHelper.getInstance().Write(structs.GetStoreInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommentsInfo() != null) {
				
				oprot.WriteFieldBegin("commentsInfo");
				
				com.vip.adp.api.open.service.GoodsCommentsInfoHelper.getInstance().Write(structs.GetCommentsInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreServiceCapability() != null) {
				
				oprot.WriteFieldBegin("storeServiceCapability");
				
				com.vip.adp.api.open.service.StoreServiceCapabilityHelper.getInstance().Write(structs.GetStoreServiceCapability(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteI64((long)structs.GetBrandId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSchemeStartTime() != null) {
				
				oprot.WriteFieldBegin("schemeStartTime");
				oprot.WriteI64((long)structs.GetSchemeStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GoodsInfo bean){
			
			
		}
		
	}
	
}