using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.product{
	
	
	
	public class AppendSkusResponseHelper : TBeanSerializer<AppendSkusResponse>
	{
		
		public static AppendSkusResponseHelper OBJ = new AppendSkusResponseHelper();
		
		public static AppendSkusResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AppendSkusResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("success".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetSuccess(value);
					}
					
					
					
					
					
					if ("error_msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetError_msg(value);
					}
					
					
					
					
					
					if ("spu_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpu_id(value);
					}
					
					
					
					
					
					if ("success_skus".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.product.SuccessSku> value;
						
						value = new List<vipapis.marketplace.product.SuccessSku>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.product.SuccessSku elem1;
								
								elem1 = new vipapis.marketplace.product.SuccessSku();
								vipapis.marketplace.product.SuccessSkuHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSuccess_skus(value);
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
		
		
		public void Write(AppendSkusResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSuccess() != null) {
				
				oprot.WriteFieldBegin("success");
				oprot.WriteBool((bool)structs.GetSuccess());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("success can not be null!");
			}
			
			
			if(structs.GetError_msg() != null) {
				
				oprot.WriteFieldBegin("error_msg");
				oprot.WriteString(structs.GetError_msg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpu_id() != null) {
				
				oprot.WriteFieldBegin("spu_id");
				oprot.WriteString(structs.GetSpu_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccess_skus() != null) {
				
				oprot.WriteFieldBegin("success_skus");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.product.SuccessSku _item0 in structs.GetSuccess_skus()){
					
					
					vipapis.marketplace.product.SuccessSkuHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AppendSkusResponse bean){
			
			
		}
		
	}
	
}