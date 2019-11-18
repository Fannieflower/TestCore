using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponCoreModelHelper : TBeanSerializer<CouponCoreModel>
	{
		
		public static CouponCoreModelHelper OBJ = new CouponCoreModelHelper();
		
		public static CouponCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponCoreModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("couponCommonModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.CouponCommonModel value;
						
						value = new com.vip.pms.data.service.CouponCommonModel();
						com.vip.pms.data.service.CouponCommonModelHelper.getInstance().Read(value, iprot);
						
						structs.SetCouponCommonModel(value);
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
					
					
					
					
					
					if ("deliveryNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetDeliveryNum(value);
					}
					
					
					
					
					
					if ("userBindLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUserBindLimit(value);
					}
					
					
					
					
					
					if ("useTimeType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUseTimeType(value);
					}
					
					
					
					
					
					if ("relativeDays".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRelativeDays(value);
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
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("userTagList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActAudienceConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActAudienceConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActAudienceConfigModel elem2;
								
								elem2 = new com.vip.pms.data.service.PmsActAudienceConfigModel();
								com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetUserTagList(value);
					}
					
					
					
					
					
					if ("memberPropList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActAudienceConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActAudienceConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActAudienceConfigModel elem4;
								
								elem4 = new com.vip.pms.data.service.PmsActAudienceConfigModel();
								com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetMemberPropList(value);
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
		
		
		public void Write(CouponCoreModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCouponCommonModel() != null) {
				
				oprot.WriteFieldBegin("couponCommonModel");
				
				com.vip.pms.data.service.CouponCommonModelHelper.getInstance().Write(structs.GetCouponCommonModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponCommonModel can not be null!");
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
			
			
			if(structs.GetDeliveryNum() != null) {
				
				oprot.WriteFieldBegin("deliveryNum");
				oprot.WriteI32((int)structs.GetDeliveryNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("deliveryNum can not be null!");
			}
			
			
			if(structs.GetUserBindLimit() != null) {
				
				oprot.WriteFieldBegin("userBindLimit");
				oprot.WriteI32((int)structs.GetUserBindLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userBindLimit can not be null!");
			}
			
			
			if(structs.GetUseTimeType() != null) {
				
				oprot.WriteFieldBegin("useTimeType");
				oprot.WriteI32((int)structs.GetUseTimeType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("useTimeType can not be null!");
			}
			
			
			if(structs.GetRelativeDays() != null) {
				
				oprot.WriteFieldBegin("relativeDays");
				oprot.WriteI32((int)structs.GetRelativeDays()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("relativeDays can not be null!");
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
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetUserTagList() != null) {
				
				oprot.WriteFieldBegin("userTagList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActAudienceConfigModel _item0 in structs.GetUserTagList()){
					
					
					com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMemberPropList() != null) {
				
				oprot.WriteFieldBegin("memberPropList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActAudienceConfigModel _item0 in structs.GetMemberPropList()){
					
					
					com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponCoreModel bean){
			
			
		}
		
	}
	
}