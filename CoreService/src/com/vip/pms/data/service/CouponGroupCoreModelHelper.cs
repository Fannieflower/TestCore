using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponGroupCoreModelHelper : TBeanSerializer<CouponGroupCoreModel>
	{
		
		public static CouponGroupCoreModelHelper OBJ = new CouponGroupCoreModelHelper();
		
		public static CouponGroupCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponGroupCoreModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("msgGet".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsgGet(value);
					}
					
					
					
					
					
					if ("channel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannel(value);
					}
					
					
					
					
					
					if ("couponType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetCouponType(value);
					}
					
					
					
					
					
					if ("couponCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponCode(value);
					}
					
					
					
					
					
					if ("deliveryType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDeliveryType(value);
					}
					
					
					
					
					
					if ("sendNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSendNum(value);
					}
					
					
					
					
					
					if ("userBindLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUserBindLimit(value);
					}
					
					
					
					
					
					if ("salt".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalt(value);
					}
					
					
					
					
					
					if ("isNewCoupon".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNewCoupon(value);
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
					
					
					
					
					
					if ("couponCommonModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponCommonModel> value;
						
						value = new List<com.vip.pms.data.service.CouponCommonModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponCommonModel elem1;
								
								elem1 = new com.vip.pms.data.service.CouponCommonModel();
								com.vip.pms.data.service.CouponCommonModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCouponCommonModelList(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
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
		
		
		public void Write(CouponGroupCoreModel structs, Protocol oprot){
			
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
			
			
			if(structs.GetMsgGet() != null) {
				
				oprot.WriteFieldBegin("msgGet");
				oprot.WriteString(structs.GetMsgGet());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("msgGet can not be null!");
			}
			
			
			if(structs.GetChannel() != null) {
				
				oprot.WriteFieldBegin("channel");
				oprot.WriteString(structs.GetChannel());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channel can not be null!");
			}
			
			
			if(structs.GetCouponType() != null) {
				
				oprot.WriteFieldBegin("couponType");
				oprot.WriteI32((int)structs.GetCouponType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponType can not be null!");
			}
			
			
			if(structs.GetCouponCode() != null) {
				
				oprot.WriteFieldBegin("couponCode");
				oprot.WriteString(structs.GetCouponCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryType() != null) {
				
				oprot.WriteFieldBegin("deliveryType");
				oprot.WriteI32((int)structs.GetDeliveryType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deliveryType can not be null!");
			}
			
			
			if(structs.GetSendNum() != null) {
				
				oprot.WriteFieldBegin("sendNum");
				oprot.WriteI32((int)structs.GetSendNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sendNum can not be null!");
			}
			
			
			if(structs.GetUserBindLimit() != null) {
				
				oprot.WriteFieldBegin("userBindLimit");
				oprot.WriteI32((int)structs.GetUserBindLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userBindLimit can not be null!");
			}
			
			
			if(structs.GetSalt() != null) {
				
				oprot.WriteFieldBegin("salt");
				oprot.WriteString(structs.GetSalt());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("salt can not be null!");
			}
			
			
			if(structs.GetIsNewCoupon() != null) {
				
				oprot.WriteFieldBegin("isNewCoupon");
				oprot.WriteBool((bool)structs.GetIsNewCoupon());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNewCoupon can not be null!");
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
			
			
			if(structs.GetCouponCommonModelList() != null) {
				
				oprot.WriteFieldBegin("couponCommonModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponCommonModel _item0 in structs.GetCouponCommonModelList()){
					
					
					com.vip.pms.data.service.CouponCommonModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponCommonModelList can not be null!");
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponGroupCoreModel bean){
			
			
		}
		
	}
	
}