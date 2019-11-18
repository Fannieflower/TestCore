using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.aftersale{
	
	
	
	public class CreateReturnApplyReqHelper : TBeanSerializer<CreateReturnApplyReq>
	{
		
		public static CreateReturnApplyReqHelper OBJ = new CreateReturnApplyReqHelper();
		
		public static CreateReturnApplyReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateReturnApplyReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("return_apply".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.aftersale.ReturnApply value;
						
						value = new com.vip.vop.cup.api.aftersale.ReturnApply();
						com.vip.vop.cup.api.aftersale.ReturnApplyHelper.getInstance().Read(value, iprot);
						
						structs.SetReturn_apply(value);
					}
					
					
					
					
					
					if ("return_apply_goods".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.aftersale.ReturnApplyGood> value;
						
						value = new List<com.vip.vop.cup.api.aftersale.ReturnApplyGood>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.aftersale.ReturnApplyGood elem1;
								
								elem1 = new com.vip.vop.cup.api.aftersale.ReturnApplyGood();
								com.vip.vop.cup.api.aftersale.ReturnApplyGoodHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetReturn_apply_goods(value);
					}
					
					
					
					
					
					if ("consignee".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.aftersale.Consignee value;
						
						value = new com.vip.vop.cup.api.aftersale.Consignee();
						com.vip.vop.cup.api.aftersale.ConsigneeHelper.getInstance().Read(value, iprot);
						
						structs.SetConsignee(value);
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
		
		
		public void Write(CreateReturnApplyReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturn_apply() != null) {
				
				oprot.WriteFieldBegin("return_apply");
				
				com.vip.vop.cup.api.aftersale.ReturnApplyHelper.getInstance().Write(structs.GetReturn_apply(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("return_apply can not be null!");
			}
			
			
			if(structs.GetReturn_apply_goods() != null) {
				
				oprot.WriteFieldBegin("return_apply_goods");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.aftersale.ReturnApplyGood _item0 in structs.GetReturn_apply_goods()){
					
					
					com.vip.vop.cup.api.aftersale.ReturnApplyGoodHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("return_apply_goods can not be null!");
			}
			
			
			if(structs.GetConsignee() != null) {
				
				oprot.WriteFieldBegin("consignee");
				
				com.vip.vop.cup.api.aftersale.ConsigneeHelper.getInstance().Write(structs.GetConsignee(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateReturnApplyReq bean){
			
			
		}
		
	}
	
}