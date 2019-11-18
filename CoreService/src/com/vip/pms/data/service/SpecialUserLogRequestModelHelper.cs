using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class SpecialUserLogRequestModelHelper : TBeanSerializer<SpecialUserLogRequestModel>
	{
		
		public static SpecialUserLogRequestModelHelper OBJ = new SpecialUserLogRequestModelHelper();
		
		public static SpecialUserLogRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SpecialUserLogRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("orderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderNo(value);
					}
					
					
					
					
					
					if ("orderAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrderAmount(value);
					}
					
					
					
					
					
					if ("orderHash".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderHash(value);
					}
					
					
					
					
					
					if ("refInfoList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.RefInfoModel> value;
						
						value = new List<com.vip.pms.data.service.RefInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.RefInfoModel elem0;
								
								elem0 = new com.vip.pms.data.service.RefInfoModel();
								com.vip.pms.data.service.RefInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRefInfoList(value);
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
		
		
		public void Write(SpecialUserLogRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteString(structs.GetUserId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			if(structs.GetOrderNo() != null) {
				
				oprot.WriteFieldBegin("orderNo");
				oprot.WriteString(structs.GetOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderAmount() != null) {
				
				oprot.WriteFieldBegin("orderAmount");
				oprot.WriteDouble((double)structs.GetOrderAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderAmount can not be null!");
			}
			
			
			if(structs.GetOrderHash() != null) {
				
				oprot.WriteFieldBegin("orderHash");
				oprot.WriteString(structs.GetOrderHash());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderHash can not be null!");
			}
			
			
			if(structs.GetRefInfoList() != null) {
				
				oprot.WriteFieldBegin("refInfoList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.RefInfoModel _item0 in structs.GetRefInfoList()){
					
					
					com.vip.pms.data.service.RefInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refInfoList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SpecialUserLogRequestModel bean){
			
			
		}
		
	}
	
}