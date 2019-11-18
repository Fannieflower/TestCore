using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractAuditParamsHelper : TBeanSerializer<ProtContractAuditParams>
	{
		
		public static ProtContractAuditParamsHelper OBJ = new ProtContractAuditParamsHelper();
		
		public static ProtContractAuditParamsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractAuditParams structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("protNos".Equals(schemeField.Trim())){
						
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
						
						structs.SetProtNos(value);
					}
					
					
					
					
					
					if ("isAgree".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIsAgree(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("stage".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetStage(value);
					}
					
					
					
					
					
					if ("createOperatorId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetCreateOperatorId(value);
					}
					
					
					
					
					
					if ("brandGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.BrandGoods> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.BrandGoods>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.BrandGoods elem1;
								
								elem1 = new com.vip.api.promotion.vis.protcontract.service.BrandGoods();
								com.vip.api.promotion.vis.protcontract.service.BrandGoodsHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBrandGoodsList(value);
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
		
		
		public void Write(ProtContractAuditParams structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProtNos() != null) {
				
				oprot.WriteFieldBegin("protNos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetProtNos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("protNos can not be null!");
			}
			
			
			if(structs.GetIsAgree() != null) {
				
				oprot.WriteFieldBegin("isAgree");
				oprot.WriteString(structs.GetIsAgree());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isAgree can not be null!");
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStage() != null) {
				
				oprot.WriteFieldBegin("stage");
				oprot.WriteByte((byte)structs.GetStage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("stage can not be null!");
			}
			
			
			if(structs.GetCreateOperatorId() != null) {
				
				oprot.WriteFieldBegin("createOperatorId");
				oprot.WriteI32((int)structs.GetCreateOperatorId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("createOperatorId can not be null!");
			}
			
			
			if(structs.GetBrandGoodsList() != null) {
				
				oprot.WriteFieldBegin("brandGoodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.BrandGoods _item0 in structs.GetBrandGoodsList()){
					
					
					com.vip.api.promotion.vis.protcontract.service.BrandGoodsHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractAuditParams bean){
			
			
		}
		
	}
	
}