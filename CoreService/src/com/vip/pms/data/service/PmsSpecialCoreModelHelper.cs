using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsSpecialCoreModelHelper : TBeanSerializer<PmsSpecialCoreModel>
	{
		
		public static PmsSpecialCoreModelHelper OBJ = new PmsSpecialCoreModelHelper();
		
		public static PmsSpecialCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsSpecialCoreModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("specialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpecialNo(value);
					}
					
					
					
					
					
					if ("category".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetCategory(value);
					}
					
					
					
					
					
					if ("actType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActType(value);
					}
					
					
					
					
					
					if ("actRange".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActRange(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
					}
					
					
					
					
					
					if ("actMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActMsg(value);
					}
					
					
					
					
					
					if ("goodsMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsMsg(value);
					}
					
					
					
					
					
					if ("iconMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIconMsg(value);
					}
					
					
					
					
					
					if ("favorable".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetFavorable(value);
					}
					
					
					
					
					
					if ("limitPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLimitPrice(value);
					}
					
					
					
					
					
					if ("enterpriseList".Equals(schemeField.Trim())){
						
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
						
						structs.SetEnterpriseList(value);
					}
					
					
					
					
					
					if ("specialFavList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsSpecialFavModel> value;
						
						value = new List<com.vip.pms.data.service.PmsSpecialFavModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsSpecialFavModel elem1;
								
								elem1 = new com.vip.pms.data.service.PmsSpecialFavModel();
								com.vip.pms.data.service.PmsSpecialFavModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSpecialFavList(value);
					}
					
					
					
					
					
					if ("platformList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem3;
								elem3 = iprot.ReadString();
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPlatformList(value);
					}
					
					
					
					
					
					if ("beginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBeginTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("specialScopeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem4;
								elem4 = iprot.ReadString();
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSpecialScopeList(value);
					}
					
					
					
					
					
					if ("excludeRangeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem5;
								elem5 = iprot.ReadString();
								
								value.Add(elem5);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetExcludeRangeList(value);
					}
					
					
					
					
					
					if ("icon".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIcon(value);
					}
					
					
					
					
					
					if ("uiThemeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUiThemeCode(value);
					}
					
					
					
					
					
					if ("businessCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBusinessCode(value);
					}
					
					
					
					
					
					if ("channelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem6;
								elem6 = iprot.ReadI32(); 
								
								value.Add(elem6);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetChannelList(value);
					}
					
					
					
					
					
					if ("promotionObjectId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPromotionObjectId(value);
					}
					
					
					
					
					
					if ("mainNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMainNo(value);
					}
					
					
					
					
					
					if ("planId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPlanId(value);
					}
					
					
					
					
					
					if ("prestartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPrestartTime(value);
					}
					
					
					
					
					
					if ("crazyType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetCrazyType(value);
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
		
		
		public void Write(PmsSpecialCoreModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSpecialNo() != null) {
				
				oprot.WriteFieldBegin("specialNo");
				oprot.WriteString(structs.GetSpecialNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("specialNo can not be null!");
			}
			
			
			if(structs.GetCategory() != null) {
				
				oprot.WriteFieldBegin("category");
				oprot.WriteI32((int)structs.GetCategory()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("category can not be null!");
			}
			
			
			if(structs.GetActType() != null) {
				
				oprot.WriteFieldBegin("actType");
				oprot.WriteI32((int)structs.GetActType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actType can not be null!");
			}
			
			
			if(structs.GetActRange() != null) {
				
				oprot.WriteFieldBegin("actRange");
				oprot.WriteI32((int)structs.GetActRange()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actRange can not be null!");
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actName can not be null!");
			}
			
			
			if(structs.GetActMsg() != null) {
				
				oprot.WriteFieldBegin("actMsg");
				oprot.WriteString(structs.GetActMsg());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actMsg can not be null!");
			}
			
			
			if(structs.GetGoodsMsg() != null) {
				
				oprot.WriteFieldBegin("goodsMsg");
				oprot.WriteString(structs.GetGoodsMsg());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsMsg can not be null!");
			}
			
			
			if(structs.GetIconMsg() != null) {
				
				oprot.WriteFieldBegin("iconMsg");
				oprot.WriteString(structs.GetIconMsg());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("iconMsg can not be null!");
			}
			
			
			if(structs.GetFavorable() != null) {
				
				oprot.WriteFieldBegin("favorable");
				oprot.WriteDouble((double)structs.GetFavorable());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("favorable can not be null!");
			}
			
			
			if(structs.GetLimitPrice() != null) {
				
				oprot.WriteFieldBegin("limitPrice");
				oprot.WriteString(structs.GetLimitPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEnterpriseList() != null) {
				
				oprot.WriteFieldBegin("enterpriseList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetEnterpriseList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialFavList() != null) {
				
				oprot.WriteFieldBegin("specialFavList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsSpecialFavModel _item0 in structs.GetSpecialFavList()){
					
					
					com.vip.pms.data.service.PmsSpecialFavModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlatformList() != null) {
				
				oprot.WriteFieldBegin("platformList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetPlatformList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBeginTime() != null) {
				
				oprot.WriteFieldBegin("beginTime");
				oprot.WriteI64((long)structs.GetBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("beginTime can not be null!");
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("endTime can not be null!");
			}
			
			
			if(structs.GetSpecialScopeList() != null) {
				
				oprot.WriteFieldBegin("specialScopeList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSpecialScopeList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExcludeRangeList() != null) {
				
				oprot.WriteFieldBegin("excludeRangeList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetExcludeRangeList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIcon() != null) {
				
				oprot.WriteFieldBegin("icon");
				oprot.WriteString(structs.GetIcon());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUiThemeCode() != null) {
				
				oprot.WriteFieldBegin("uiThemeCode");
				oprot.WriteI32((int)structs.GetUiThemeCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessCode() != null) {
				
				oprot.WriteFieldBegin("businessCode");
				oprot.WriteI32((int)structs.GetBusinessCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelList() != null) {
				
				oprot.WriteFieldBegin("channelList");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetChannelList()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPromotionObjectId() != null) {
				
				oprot.WriteFieldBegin("promotionObjectId");
				oprot.WriteI64((long)structs.GetPromotionObjectId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMainNo() != null) {
				
				oprot.WriteFieldBegin("mainNo");
				oprot.WriteString(structs.GetMainNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlanId() != null) {
				
				oprot.WriteFieldBegin("planId");
				oprot.WriteI64((long)structs.GetPlanId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrestartTime() != null) {
				
				oprot.WriteFieldBegin("prestartTime");
				oprot.WriteI32((int)structs.GetPrestartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCrazyType() != null) {
				
				oprot.WriteFieldBegin("crazyType");
				oprot.WriteByte((byte)structs.GetCrazyType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsSpecialCoreModel bean){
			
			
		}
		
	}
	
}