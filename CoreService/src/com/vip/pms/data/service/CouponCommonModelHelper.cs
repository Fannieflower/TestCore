using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponCommonModelHelper : TBeanSerializer<CouponCommonModel>
	{
		
		public static CouponCommonModelHelper OBJ = new CouponCommonModelHelper();
		
		public static CouponCommonModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponCommonModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetName(value);
					}
					
					
					
					
					
					if ("range".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRange(value);
					}
					
					
					
					
					
					if ("offersType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOffersType(value);
					}
					
					
					
					
					
					if ("giveType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGiveType(value);
					}
					
					
					
					
					
					if ("buy".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetBuy(value);
					}
					
					
					
					
					
					if ("offer".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOffer(value);
					}
					
					
					
					
					
					if ("isOnlinePay".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsOnlinePay(value);
					}
					
					
					
					
					
					if ("isAllowBlackList".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsAllowBlackList(value);
					}
					
					
					
					
					
					if ("useBeginTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUseBeginTime(value);
					}
					
					
					
					
					
					if ("useEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUseEndTime(value);
					}
					
					
					
					
					
					if ("platformList".Equals(schemeField.Trim())){
						
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
						
						structs.SetPlatformList(value);
					}
					
					
					
					
					
					if ("rangeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponRangeModel> value;
						
						value = new List<com.vip.pms.data.service.CouponRangeModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponRangeModel elem1;
								
								elem1 = new com.vip.pms.data.service.CouponRangeModel();
								com.vip.pms.data.service.CouponRangeModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRangeList(value);
					}
					
					
					
					
					
					if ("saleModelList".Equals(schemeField.Trim())){
						
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
						
						structs.SetSaleModelList(value);
					}
					
					
					
					
					
					if ("sendNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSendNum(value);
					}
					
					
					
					
					
					if ("categoryChannelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategoryChannelId(value);
					}
					
					
					
					
					
					if ("categoryList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponRangeModel> value;
						
						value = new List<com.vip.pms.data.service.CouponRangeModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponRangeModel elem4;
								
								elem4 = new com.vip.pms.data.service.CouponRangeModel();
								com.vip.pms.data.service.CouponRangeModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCategoryList(value);
					}
					
					
					
					
					
					if ("salt".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalt(value);
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
		
		
		public void Write(CouponCommonModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteString(structs.GetId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetName() != null) {
				
				oprot.WriteFieldBegin("name");
				oprot.WriteString(structs.GetName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("name can not be null!");
			}
			
			
			if(structs.GetRange() != null) {
				
				oprot.WriteFieldBegin("range");
				oprot.WriteI32((int)structs.GetRange()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("range can not be null!");
			}
			
			
			if(structs.GetOffersType() != null) {
				
				oprot.WriteFieldBegin("offersType");
				oprot.WriteI32((int)structs.GetOffersType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("offersType can not be null!");
			}
			
			
			if(structs.GetGiveType() != null) {
				
				oprot.WriteFieldBegin("giveType");
				oprot.WriteI32((int)structs.GetGiveType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("giveType can not be null!");
			}
			
			
			if(structs.GetBuy() != null) {
				
				oprot.WriteFieldBegin("buy");
				oprot.WriteDouble((double)structs.GetBuy());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buy can not be null!");
			}
			
			
			if(structs.GetOffer() != null) {
				
				oprot.WriteFieldBegin("offer");
				oprot.WriteDouble((double)structs.GetOffer());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("offer can not be null!");
			}
			
			
			if(structs.GetIsOnlinePay() != null) {
				
				oprot.WriteFieldBegin("isOnlinePay");
				oprot.WriteBool((bool)structs.GetIsOnlinePay());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isOnlinePay can not be null!");
			}
			
			
			if(structs.GetIsAllowBlackList() != null) {
				
				oprot.WriteFieldBegin("isAllowBlackList");
				oprot.WriteBool((bool)structs.GetIsAllowBlackList());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAllowBlackList can not be null!");
			}
			
			
			if(structs.GetUseBeginTime() != null) {
				
				oprot.WriteFieldBegin("useBeginTime");
				oprot.WriteI64((long)structs.GetUseBeginTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("useBeginTime can not be null!");
			}
			
			
			if(structs.GetUseEndTime() != null) {
				
				oprot.WriteFieldBegin("useEndTime");
				oprot.WriteI64((long)structs.GetUseEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("useEndTime can not be null!");
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
			
			else{
				throw new ArgumentException("platformList can not be null!");
			}
			
			
			if(structs.GetRangeList() != null) {
				
				oprot.WriteFieldBegin("rangeList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponRangeModel _item0 in structs.GetRangeList()){
					
					
					com.vip.pms.data.service.CouponRangeModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleModelList() != null) {
				
				oprot.WriteFieldBegin("saleModelList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSaleModelList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSendNum() != null) {
				
				oprot.WriteFieldBegin("sendNum");
				oprot.WriteI32((int)structs.GetSendNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryChannelId() != null) {
				
				oprot.WriteFieldBegin("categoryChannelId");
				oprot.WriteString(structs.GetCategoryChannelId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategoryList() != null) {
				
				oprot.WriteFieldBegin("categoryList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponRangeModel _item0 in structs.GetCategoryList()){
					
					
					com.vip.pms.data.service.CouponRangeModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalt() != null) {
				
				oprot.WriteFieldBegin("salt");
				oprot.WriteString(structs.GetSalt());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponCommonModel bean){
			
			
		}
		
	}
	
}