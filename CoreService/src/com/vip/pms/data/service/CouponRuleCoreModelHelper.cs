using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponRuleCoreModelHelper : TBeanSerializer<CouponRuleCoreModel>
	{
		
		public static CouponRuleCoreModelHelper OBJ = new CouponRuleCoreModelHelper();
		
		public static CouponRuleCoreModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponRuleCoreModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetId(value);
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
					
					
					
					
					
					if ("couponNoList".Equals(schemeField.Trim())){
						
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
						
						structs.SetCouponNoList(value);
					}
					
					
					
					
					
					if ("couponRuleChannelModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponRuleChannelModel> value;
						
						value = new List<com.vip.pms.data.service.CouponRuleChannelModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponRuleChannelModel elem1;
								
								elem1 = new com.vip.pms.data.service.CouponRuleChannelModel();
								com.vip.pms.data.service.CouponRuleChannelModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCouponRuleChannelModelList(value);
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
		
		
		public void Write(CouponRuleCoreModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI32((int)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
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
			
			
			if(structs.GetCouponNoList() != null) {
				
				oprot.WriteFieldBegin("couponNoList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetCouponNoList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponNoList can not be null!");
			}
			
			
			if(structs.GetCouponRuleChannelModelList() != null) {
				
				oprot.WriteFieldBegin("couponRuleChannelModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponRuleChannelModel _item0 in structs.GetCouponRuleChannelModelList()){
					
					
					com.vip.pms.data.service.CouponRuleChannelModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponRuleChannelModelList can not be null!");
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
		
		
		public void Validate(CouponRuleCoreModel bean){
			
			
		}
		
	}
	
}